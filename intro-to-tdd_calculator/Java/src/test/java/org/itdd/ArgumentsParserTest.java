package org.itdd;

import org.junit.Test;

import static org.assertj.core.api.StrictAssertions.assertThat;

/*

 A simpler version of http://codingdojo.org/kata/Args/

 If a program is called with these arguments:

   -l -p 8080 -d /usr/logs

 then:

   - "l" indicates logging and is a boolean flag whose value will be True if present False if not
   - "p" indicates port flag which has an integer value
   - "d" (directory) flag has a string value

 they have default values:

   - False for a boolean
   - 0 for a number
   - "" for a string

 */
public class ArgumentsParserTest {
    @Test
    public void whenThen() {
        assertThat(1).isEqualTo(2);
    }
}
